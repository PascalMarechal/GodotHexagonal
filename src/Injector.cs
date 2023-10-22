namespace TestGame;

using Godot;

public partial class Injector : Node {
  public ICountData CountDB { private set; get; } = new CountData(0);
  public IIncrementCount IncrementCount { private set; get; }

  public Injector() {
    IncrementCount = new IncrementCount(CountDB);
  }
}
