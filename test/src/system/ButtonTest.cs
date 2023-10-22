namespace TestGame;

using System.Threading.Tasks;
using Chickensoft.GoDotTest;
using Godot;
using GodotTestDriver;
using GodotTestDriver.Drivers;
using Shouldly;

public class ButtonTest : TestClass {
  private CountPresenter _buttonPresenter = default!;
  private Fixture _fixture = default!;
  private Label _countView = default!;
  private Button _countButton = default!;

  public ButtonTest(Node testScene) : base(testScene) {
  }

  [SetupAll]
  public async Task Setup() {
    _fixture = new Fixture(TestScene.GetTree());
    _buttonPresenter = await _fixture.LoadAndAddScene<CountPresenter>($"res://scenes/UI.tscn");
    _countView = (Label)_buttonPresenter.FindChild("CountValue");
    _countButton = (Button)_buttonPresenter.FindChild("TestButton");
  }

  [CleanupAll]
  public void Cleanup() => _fixture.Cleanup();

  [Test]
  public async Task TestButtonUpdatesCountView() {
    var buttonDriver = new ButtonDriver(() => _countButton);
    await buttonDriver.ClickCenter();
    _countView.Text.ShouldBe("1");
  }
}
