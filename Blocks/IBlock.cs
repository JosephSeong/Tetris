using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class IBlock : Block                 // 네가지 회전 상태에 대한 타일 위치를 저장
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[] { new(1,0), new(1,1), new(1,2), new(1,3) },
            new Position[] { new(0,2), new(1,2), new(2,2), new(3,2) },
            new Position[] { new(2,0), new(2,1), new(2,2), new(2,3) },
            new Position[] { new(0,1), new(1,1), new(2,1), new(3,1) }
        };

        public override int Id => 1; 
        protected override Position StartOffset => new Position(-1, 3);  // 맨 위 행 중간에 생성
        protected override Position[][] Tiles => tiles;                  // 타일 배열 반환
    }
}