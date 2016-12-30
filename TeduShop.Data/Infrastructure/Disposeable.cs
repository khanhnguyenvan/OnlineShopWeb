using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class Disposeable : IDisposable
    {
        private bool _isDispose;


        ~Disposeable()
        {

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        private void Dispose(bool disposing)
        {
            if (!_isDispose && disposing)
            {
                DisposeCore();
            }
            _isDispose = true;
        }

        protected virtual void DisposeCore()
        {

        }
    }
}
