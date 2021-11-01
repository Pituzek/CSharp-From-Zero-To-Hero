using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public interface ILogBase
    {
        /// <summary>
        /// Abstract class
        /// </summary>
        /// <param name="message"></param>
        public void Log(ILogMessage message);

    }
}
