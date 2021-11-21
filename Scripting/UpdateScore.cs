using System.Collections.Generic;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Scripting
{
    public class UpdateScore : Action
    {
        ScoreBoard _scoreBoard = new ScoreBoard();

        public UpdateScore(ScoreBoard scoreBoard)
        {
            _scoreBoard = scoreBoard;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            // throw new System.NotImplementedException();
            _scoreBoard.AddScoreBoardPoint();
        }
    }
}