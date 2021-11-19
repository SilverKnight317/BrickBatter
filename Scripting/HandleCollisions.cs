using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;


namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// An action to appropriately handle any collisions in the game.
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService _audioService;
        private int countOfTen = 10;
        private int brickRemovedCount;

        public HandleCollisionsAction(PhysicsService physicsService, AudioService audioService)
        {
            _physicsService = physicsService;
            _audioService = audioService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> balls = cast["balls"]; /*[0];*/ // There is only one
            List<Actor> bricks = cast["bricks"];
            List<Actor> paddles = cast["paddle"]; // Get all the artifacts
            List<Actor> removeBrick = new List<Actor>();
            foreach(Actor ball in balls)
            {
                foreach (Actor actor in paddles)
                {
                    Paddle paddle = (Paddle)actor;
                    if (_physicsService.IsCollision( ball, paddle))
                    {
                        ball.ChangeVelocityY();
                        _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    }
                }
                foreach(Actor actor in bricks)
                {
                    Brick brick = (Brick)actor;
                    if(_physicsService.IsCollision( ball, brick))
                    {
                        ball.ChangeVelocityY();
                        _audioService.PlaySound(Constants.SOUND_BOUNCE);
                        removeBrick.Add(brick);
                        brickRemovedCount += 1; /*
                        if(brickRemovedCount > countOfTen)
                        {
                            Ball ballnew = new Ball();
                            ballnew.SetPosition(new Point(Constants.BALL_X, Constants.BALL_Y));
                            ballnew.SetVelocity(new Point(Constants.BALL_DX, Constants.BALL_DY));
                            cast["balls"].Add(ballnew);
                            countOfTen += 10;
                        } */
                    }
                }
                foreach(Actor brick in removeBrick)
                {
                    cast["bricks"].Remove(brick);
                }
            }
        }

    }
}