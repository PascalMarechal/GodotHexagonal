namespace TestGame;

public class CountData : ICountData {

  public CountData(int value) {
    Count = new Count(value);
  }

  public Count Count { get; set; }
}