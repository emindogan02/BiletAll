namespace BiletAll_Mvc.Helper {
  public static class RandomPnrCodeGenerator {
    public static Random random = new Random();

    public static string RandomStringChar(int length) {
      const string chars = "ABCDEFGHIJKLMNPQRSTUVWXYZ";
      return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public static string RandomStringNum(int length) {
      const string chars = "1234567890";
      return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }
  }
}
