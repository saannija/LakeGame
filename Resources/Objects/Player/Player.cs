using Godot;
using System;

public class Player : KinematicBody2D
{ 
    const float speed = 50;
    public void move()
    {
        Vector2 inputDir = new Vector2();
        if (Input.IsActionPressed("up")) { 
            inputDir = new Vector2(-1,-1);
        }
        if (Input.IsActionPressed("down")) {
            inputDir = new Vector2(1, 1);
        }
        if (Input.IsActionPressed("left"))
        {
            inputDir = new Vector2(-1, 1);
        }
        if (Input.IsActionPressed("right"))
        {
            inputDir = new Vector2(1, -1);
        }
        Vector2 velocity = inputDir * speed;

        MoveAndSlide(new Vector2(velocity.x-velocity.y,(velocity.x+velocity.y)/2));
    }

    public override void _Process(float delta)
    {
        move();
    }
}
