namespace TestGame;

using Godot;

public partial class CountPresenter : Control, ICountPresenter {

  [Signal]
  public delegate void CountChangedEventHandler(int value);

  public void Show(ICountPresenter.CountData count) {
    EmitSignal(SignalName.CountChanged, count.Value);
  }
}