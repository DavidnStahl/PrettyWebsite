using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyWebsite.Models.Blocks;

namespace PrettyWebsite.Models.ViewModels.Interfaces
{
    public interface IBlockViewModel<out T>
    {
        T CurrentBlock { get; }
    }
}
