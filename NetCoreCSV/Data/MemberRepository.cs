using System;
using System.Collections.Generic;
using System.Linq;
using NetCoreCSV.Models;

namespace NetCoreCSV.Data {
  public interface IMemberRepository {
    void Add(Member Member);
    IEnumerable<Member> GetMembers();
  }

  public class MemberRepository : IMemberRepository {
    private NetCoreCSVContext Context { get; }

    public MemberRepository(NetCoreCSVContext context) {
      Context = context;
    }

    // 追加処理は結局使いませんでした。実際にはCRUD処理を定義するはずです。
    public void Add(Member Member) {
      Member.CreatedAt = DateTime.Now;
      Context.Members.Add(Member);
      Context.SaveChanges();
    }

    public IEnumerable<Member> GetMembers() => Context.Members.AsEnumerable();
  }
}
