using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetCoreCSV.Data;
using NetCoreCSV.Models;

namespace NetCoreCSV.Services {
  public interface IMemberService {
    void Add(Member Member);
    IEnumerable<Member> GetMembers();
    byte[] GetCsvData();
  }

  public class MemberService : IMemberService {
    private IMemberRepository Repository { get; }

    public MemberService(IMemberRepository repository) {
      Repository = repository;
    }

    public void Add(Member Member) {
      Repository.Add(Member);
    }

    public IEnumerable<Member> GetMembers() => Repository.GetMembers();

    public byte[] GetCsvData() {
      var header = Member.GetHeaderString();
      var body = string.Join("\n", GetMembers().Select(Member => Member.ToString()));
      return Encoding.UTF8.GetBytes($"{header}\n{body}");
    }
  }
}