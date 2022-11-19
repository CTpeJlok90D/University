using System.Drawing;

namespace MovebleObjects
{
    public class Space
    {
        private List<Object> _objects = new();
        private Point _size;

        public Space(List<Object> objects, Point size)
        {
            _objects = objects;
            _size = size;
        }

        public Image Render()
        {
            Image image = new Bitmap(_size.X, _size.X);
            Graphics graphics = Graphics.FromImage(image);
            foreach (Object obj in _objects)
            {
                obj.RenderOn(graphics);
            }
            return image;
        }

        public Object? GetObjectByPoint(Point position)
        {
            foreach (Object @object in _objects)
            {
                if (@object.HaveThisCords(position))
                {
                    return @object;
                }
            }
            return null;
        }

        public void TryMoveObject(Object @object, Point offcet)
        {
            if (CanMove(@object, offcet))
            {
                @object.Move(offcet);
            }
        }

        private bool CanMove(Object @object, Point offset)
        {
            Point newPosition = new Point(@object.Position.X + offset.X, @object.Position.Y + offset.Y);
            return (newPosition.X > 0 && 
                    newPosition.Y > 0 &&
                    newPosition.X + @object.Size.X < _size.X &&
                    newPosition.Y + @object.Size.Y < _size.Y);
        }
    }
}
