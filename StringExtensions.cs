using System;
using System.Text.RegularExpressions;

public static class Extension
{
  public static int WordCount(this string str)
  {
    string[] userString = str.Split(new char[] { ' ', '.', '?' },
                                StringSplitOptions.RemoveEmptyEntries);
    int wordCount = userString.Length;
    return wordCount;
  }

  public static int TotalCharWithoutSpace(this string str)
  {
    int totalCharWithoutSpace = 0;
    string[] userString = str.Split(' ');
    foreach (string stringValue in userString)
    {
      totalCharWithoutSpace += stringValue.Length;
    }
    return totalCharWithoutSpace;
  }


// Matches a string with the specified pattern
  public static int HasStringWithPattern(this string s,string pattern)
  {
    int index = -1;
    // var s = "long string.....24X10     .....1X3";
    if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(pattern)){
        return index;
    }
    var match = Regex.Match(s, pattern);    
    return match.Success?match.Index:index;
  }

}