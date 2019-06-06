using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Dtos
{
    public class BookForUpdateDto : BookForManipulationDto 
    {
        public override string Description
        {
            get
            {
                return base.Description;
            }

            set
            {
                base.Description = value;
            }
        }
    }
}
