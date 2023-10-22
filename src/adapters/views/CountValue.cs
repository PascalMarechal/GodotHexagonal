namespace TestGame;
using Godot;

public partial class CountValue : Label {
  private void SetText(int value) => Text = value.ToString();
}
