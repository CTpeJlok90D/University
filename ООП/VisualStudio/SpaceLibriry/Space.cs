using System.Drawing;

namespace SpaceLibriry
{
    public class Space
    {
        private List<IRenderable> _objects = new();
        private Point _size;

        public Space(List<IRenderable> objects, Point size)
        {
            _objects = objects;
            _size = size;
        }

        public Image Render()
        {
            Image image = new Bitmap(_size.X, _size.X);
            Graphics graphics = Graphics.FromImage(image);
            foreach (IRenderable obj in _objects)
            {
                obj.RenderOn(graphics);
            }
            return image;
        }

        public Object? GetObjectByPoint(Point position)
        {
            foreach (IRenderable currentObject in _objects)
            {
                if (currentObject is not Object)
                {
                    continue;
                }
                if (((Object)currentObject).HaveThisCords(position))
                {
                    return (Object)currentObject;
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
