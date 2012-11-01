using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace GamePZL01 {
	class Ball : BaseObject{

		static private Texture2D TextureBall = null;

		public override void UpData() {
		}

		public override void Draw(ref SpriteBatch spriteBatch) {
			spriteBatch.Draw(TextureBall, Vector2.Zero, Color.Yellow);
		}

		public override void LoadGraph(Texture2D Tex) {
			TextureBall = Tex;
		}

	}
}
