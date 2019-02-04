using System;
namespace NetCoreCSV.Models {
  public class Member {
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Country { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }

    public static string GetHeaderString() =>
      "\"会員ID\", \"会員名\", \"国籍\", \"メールアドレス\", \"登録日時\"";

    public override string ToString() =>
      $"\"{Id}\", \"{FullName}\", \"{Country}\", \"{Email}\", \"{CreatedAt}\"";
  }
}
