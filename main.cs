using Godot;
using System;

public partial class main : Node2D
{
	[Export]
	public PackedScene MobScene { get; set; }
	
	private int _score;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
		private void GameOver()
	{
		GetNode<Timer>("MobTimer").Stop();
		GetNode<Timer>("ScoreTimer").Stop();
	}
	private void NewGame()
	{
		_score = 0;
		
		var player = GetNode<Player>("Player");
		var startPosition = GetNode<Marker2D>("StartPosition");
		player.Start(startPosition.Position);
		
		GetNode<Timer>("StartTimer").Start();
	}
}
