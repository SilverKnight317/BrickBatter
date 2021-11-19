namespace cse210_batter_csharp.Casting
{
    class Brick : Actor
    {
        private int height = Constants.BRICK_HEIGHT;
        private int width = Constants.BRICK_WIDTH;
        private string image = Constants.IMAGE_BRICK;

        public Brick()
        {
            SetHeight(height);
            SetWidth(width);
            SetImage(image);
        }
    }
}