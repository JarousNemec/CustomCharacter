using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCharacter
{
    public partial class Form1 : Form
    {
        private Character _character;
        private Pen _pen = new Pen(Color.Black, 3);

        public Form1()
        {
            InitializeComponent();
            InitializeCharacter();
            Invalidate();
        }

        private void InitializeCharacter()
        {
            Head head = new Head(150, 50, 50, 50);
            _numHeadSize.Value = (decimal)head.Width;
            var neckPos = head.GetNeckPosition();
            Body body = new Body(neckPos.X, neckPos.Y, 3, 100);
            _numBodySize.Value = (decimal)body.Width;
            Extremities hands = new Extremities(neckPos.X, neckPos.Y, 80, 20, 3);
            Legs legs = new Legs(neckPos.X, neckPos.Y + body.Height, 80, 50, 3);
            _character = new Character(head, body, hands, legs);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            _character.Head.Draw(g, _pen);
            _character.Body.Draw(g, _pen);
            _character.Hands.Draw(g, _pen);
            _character.Legs.Draw(g, _pen);
        }

        private void _numHeadSize_ValueChanged(object sender, EventArgs e)
        {
            if (_character == null)
                return;
            _character.Head.Height = (float)_numHeadSize.Value;
            _character.Head.Width = (float)_numHeadSize.Value;
            var neckPos = _character.Head.GetNeckPosition();
            _character.Body.UpdatePos(neckPos.X, neckPos.Y);
            _character.Hands.UpdatePos(neckPos.X, neckPos.Y);
            _character.Legs.UpdatePos(neckPos.X, neckPos.Y + _character.Body.Height);
            Invalidate();
        }

        private void _numBodySize_ValueChanged(object sender, EventArgs e)
        {
            _character.Body.Width = (float)_numBodySize.Value;
            _character.Legs.LineWidth = (float)_numBodySize.Value;
            Invalidate();
        }
    }
}