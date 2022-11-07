namespace MovebleObjects
{
    internal class Space
    {
        private List<Object> _objects = new();

        public Space(List<Object> objects)
        {
            _objects = objects;
        }

        public Image Render(Size size)
        {
            Image image = new Bitmap(size.Width, size.Height);
            Graphics graphics = Graphics.FromImage(image);
            foreach (Object obj in _objects)
            {
                obj.RenderOn(graphics);
            }
            return image;
        }
    }
}
