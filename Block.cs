using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles { get; }                 // 4개 회전상태에서 타일 위치 포함하는 2차원 위치 배열
        protected abstract Position StartOffset { get; }
        public abstract int Id { get; }

        private int rotationState;
        private Position offset;

        public Block()                                 
        {
            offset = new Position(StartOffset.Row, StartOffset.Column);
        }

        public IEnumerable<Position> TilePositions()                    // 회전 상태의 타일 위치에 대해 루프
        {
            foreach (Position p in Tiles[rotationState])
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
            }
        }

        public void RotateCW()                              // 시계 방향으로 90도 회전
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        public void RotateCCW()                             // 반시계 방향으로 회전
        {
            if (rotationState == 0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }
        }

        public void Move(int rows, int columns)             // 이동
        {
            offset.Row += rows;
            offset.Column += columns;
        }

        public void Reset()                                 // 회전 및 위치를 재설정
        {
            rotationState = 0;
            offset.Row = StartOffset.Row;
            offset.Column = StartOffset.Column;
        }
    }
}