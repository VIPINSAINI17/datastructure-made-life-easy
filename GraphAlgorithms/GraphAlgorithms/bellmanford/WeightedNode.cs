using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.bellmanford
{
    public class WeightedNode
    {
        public LinkedList<WeightedNode> Neigbours { get; set; }

        public Dictionary<WeightedNode, int> WeightMap { get; set; }


        public WeightedNode()
        {
            Neigbours = new LinkedList<WeightedNode>();
            WeightMap = new Dictionary<WeightedNode, int>();
        }
    }
}
