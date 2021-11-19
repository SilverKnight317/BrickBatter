namespace cse210_batter_csharp.Casting
{
    class Ball : Actor
    {
        private int _ballWidth = Constants.BALL_WIDTH;
        private int _ballHeight = Constants.BALL_HEIGHT;
        private string _ballImage = Constants.IMAGE_BALL;

        public Ball()
        {
            SetHeight(_ballHeight);
            SetWidth(_ballWidth);
            SetImage(_ballImage);
        }
    }
}