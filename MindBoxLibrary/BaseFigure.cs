

namespace MindBoxLibrary
{
    public class BaseFigure : IGeometricalFigure, IDisposable
    {
        private bool _disposedValue;
        public virtual double SquareFigure()
        {
            return 0.0;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        // Protected implementation of Dispose pattern.
        public void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                }
                _disposedValue = true;
            }
        }
    }
}
