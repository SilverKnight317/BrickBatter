namespace cse210_batter_csharp.Casting
{
    public class Paddle : Actor
    {
        private int _paddleWidth = Constants.PADDLE_WIDTH;
        private int _paddleHeight = Constants.PADDLE_HEIGHT;
        private string _paddleImage = Constants.IMAGE_PADDLE;
        // private int _paddleSpeed = Constants.PADDLE_SPEED;
        private int _paddleX = Constants.PADDLE_X;
        private int _paddleY = Constants.PADDLE_Y;
        public Paddle()
        {
            SetHeight(_paddleHeight);
            SetWidth(_paddleWidth);
            SetImage(_paddleImage);
            SetPosition(new Point(_paddleX, _paddleY));
        }

    }
}