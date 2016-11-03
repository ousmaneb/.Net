namespace PalindromeApp.Domain
{
  public class Palindrome
  {
    /// <summary>
    ///   Method to check if it's a palindrome or not
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public bool IsPalindrome(string word)

    {
      var succcess = true;

      word = word.Replace(" ", "");


      if (word.Length == 0) 
        succcess = false;
      else
        for (var i = 0; i < word.Length/2 + 1; i++)
        {
          if (word[i] != word[word.Length - i - 1])
          {
            //doesn't not succeed if it's not palindrome
            succcess = false;
            break;
          }
        }

      //Return palindrome if it's true
      return succcess;
    }
  }
}