namespace TestGame;
using Godot;

public partial class TestButton : Button {

  [Export]
  private CountPresenter? _presenter;

  private Injector? _injector;

  public override void _Ready() => _injector = GetNode<Injector>("/root/Injector");

  public void IncrementCount() => _injector?.IncrementCount.Excecute(_presenter!);

}
