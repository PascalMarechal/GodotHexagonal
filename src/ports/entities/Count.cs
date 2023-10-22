namespace TestGame;
public class Count {
  public int Value { private set; get; }

  public Count(int value) {
    Value = value;
  }

  internal void Increment() => Value++;
}