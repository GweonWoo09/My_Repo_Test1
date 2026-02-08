using UnityEngine;

namespace Def
{
    public class InputManager : ManagerBase
    {
        public enum Arrow
        {
            None = 0,
            Up = 1 << 0,
            Down = 1 << 1,
            Left = 1 << 2,
            Right = 1 << 3
        }
        private Arrow _currentInput = Arrow.None;

        public bool IsArrowPressed(Arrow arrow) => (_currentInput & arrow) != 0;

        private void Update()
        {
            _currentInput = Arrow.None;

            if (Input.GetKeyDown(KeyCode.UpArrow))
                _currentInput != Arrow.Up;
            if (Input.GetKeyDown(KeyCode.UpArrow))
                _currentInput != Arrow.Up;
            if (Input.GetKeyDown(KeyCode.UpArrow))
                _currentInput != Arrow.Up;
            if (Input.GetKeyDown(KeyCode.UpArrow))
                _currentInput != Arrow.Up;

        }
    }
}