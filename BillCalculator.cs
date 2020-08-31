using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Reading {
  public int MinValue { get; set; }
  public int MaxValue { get; set; }
  public double Charge { get; set; }

  public double CalculatedValue { get; set; }
}

public class Outcome
{
  public int Reading { get;set; }
  public Outcome(int reading) => Reading = reading;
  public List<Reading> Values { get; set; }

  public double TotalReadingCost { get; set; }  

  public readonly double StableCharge = 110;

  public  double EquipmentCharge  { get {return 1.45 * Reading;}  }

  public  double AccruedCharge  { get {
    var res= (StableCharge + EquipmentCharge+TotalReadingCost)*0.16;
    return res;
    }  
  }

  public  double TotalCost  { get {
    var res= (StableCharge + EquipmentCharge+TotalReadingCost +AccruedCharge);
    return res;
    }  
  }

  
}

public class BillCalculator
{
  //public int Reading { get; }
  public List<Reading> list = new List<Reading>(){
    new Reading(){MinValue=1,MaxValue=100,Charge=3.46},
    new Reading(){MinValue=101,MaxValue=300,Charge=7.43},
    new Reading(){MinValue=301,MaxValue=500,Charge=10.32},
    new Reading(){MinValue=501,MaxValue=5000,Charge=11.71}
  };

  public BillCalculator()
  {
  }

  public Outcome Calculate(int currentReading)
  {
    Outcome result = new Outcome(currentReading);
    int reminder = currentReading;
    double TotalCost= 0;
    if(currentReading>0){
      foreach(var item in list){
        if(reminder>0){
        int current = reminder<item.MaxValue ?reminder:item.MaxValue;
        item.CalculatedValue = current * item.Charge;
        TotalCost = TotalCost +item.CalculatedValue;
        reminder = reminder-item.MaxValue;
        }
      }
      result.Values = list;
      result.TotalReadingCost = TotalCost;
    }
    return result;
  }

 
}
