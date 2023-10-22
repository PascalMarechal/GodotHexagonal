namespace TestGame;

using System.Threading.Tasks;
using Chickensoft.GoDotTest;
using Godot;
using Shouldly;


public class IncrementCountTest : TestClass {

  public class MockedPresenter : ICountPresenter {

    public ICountPresenter.CountData Count {
      get; set;
    } = new ICountPresenter.CountData(-77);
    public void Show(ICountPresenter.CountData count) => Count = count;
  }

  public IncrementCountTest(Node testScene) : base(testScene) {
  }

  [Test]
  public async Task IncrementShouldAddOneToCount() {
    var countDB = new CountData(88);
    IIncrementCount uc = new IncrementCount(countDB);
    var presenter = new MockedPresenter();

    await Task.Run(() => uc.Excecute(presenter));

    presenter.Count.Value.ShouldBe(89);
    countDB.Count.Value.ShouldBe(89);
  }
}
