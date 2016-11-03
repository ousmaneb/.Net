using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  /// <summary>
  /// 
  /// </summary>
  public static class StringExtensions
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="word"></param>
    public static void Capitalize(this object word)
    {
      if (word is string)
      {
        var s = word.ToString();
        var lower = s.ToLowerInvariant();
        var firstCharacter = s[0].ToString().ToUpperInvariant();
        var sub = lower.Substring(1);

        word = firstCharacter + sub;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="word"></param>
    /// <param name="w"></param>
    public static void Capitalize(this object word, out string w)
    {
      w = word.ToString();

      if (word is string)
      {
        var s = word.ToString();
        var lower = s.ToLowerInvariant();
        var firstCharacter = s[0].ToString().ToUpperInvariant();
        var sub = lower.Substring(1);

        w = firstCharacter + sub;
      }
    }
  }
}