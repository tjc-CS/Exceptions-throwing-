using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class RubbishCourseworkException : Exception
    {
        private string updateRequired;

        public RubbishCourseworkException(string fix)
        {
            updateRequired = fix;
        }

        public string WhatDoIDo()
        {
            return updateRequired;
        }
    }
}
