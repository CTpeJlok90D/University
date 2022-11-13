using System.Drawing;

namespace MovebleObjects
{
    public class Space
    {
        private List<Object> _objects = new();
        private Vector2 _size;

        public Space(List<Object> objects, Vector2 size)
        {
            _objects = objects;
            _size = size;
        }

        public Image Render()
        {
            Image image = new Bitmap(_size.x, _size.y);
            Graphics graphics = Graphics.FromImage(image);
            foreach (Object obj in _objects)
            {
                obj.RenderOn(graphics);
            }
            return image;
        }

        public Object? GetObjectByVector2(Vector2 position)
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

        public void TryMoveObject(Object @object, Vector2 offcet)
        {
            if (CanMove(@object, offcet))
            {
                @object.Move(offcet);
            }
        }

        private bool CanMove(Object @object, Vector2 offset)
        {
            Vector2 newPosition = @object.Position + offset;
            return (newPosition.x > 0 && 
                    newPosition.y > 0 &&
                    newPosition.x + @object.Size.x < _size.x &&
                    newPosition.y + @object.Size.y < _size.y);
        }
    }
}
