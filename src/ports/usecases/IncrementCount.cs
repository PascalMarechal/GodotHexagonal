namespace TestGame;

public class IncrementCount : IIncrementCount {
  private readonly ICountData _countData;

  public IncrementCount(ICountData countDB) {
    _countData = countDB;
  }

  public void Excecute(ICountPresenter presenter) {
    _countData.Count.Increment();
    presenter.Show(new ICountPresenter.CountData(_countData.Count.Value));
  }
}