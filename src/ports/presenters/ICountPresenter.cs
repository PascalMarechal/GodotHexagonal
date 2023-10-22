namespace TestGame;
public interface ICountPresenter {
  public class CountData {
    public int Value { get; private set; }

    public CountData(int v) {
      Value = v;
    }
  }

  public void Show(CountData count);
}