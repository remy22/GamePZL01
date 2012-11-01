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
	class Block : BaseObject {

		static private Texture2D TextureBlock = null;

		public override void UpData() {
		}

		public override void Draw(ref SpriteBatch spriteBatch) {
			spriteBatch.Draw(TextureBlock, Vector2.Zero, Color.White);
		}

		public override void LoadGraph(Texture2D Tex) {
			TextureBlock = Tex;
		}

	}
}
