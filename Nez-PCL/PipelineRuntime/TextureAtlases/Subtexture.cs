﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Nez.TextureAtlases
{
	/// <summary>
	/// represents a single element in a texture atlas consisting of a texture and the source rectangle for the frame
	/// </summary>
	public class Subtexture : Texture
	{
		public Rectangle sourceRect;
		

		public Subtexture( Texture2D texture, Rectangle sourceRect ) : base( texture )
		{
			this.sourceRect = sourceRect;
		}


		public Subtexture( Texture2D texture ) : this( texture, new Rectangle( 0, 0, texture.Width, texture.Height ) )
		{}


		public Subtexture( Texture2D texture, int x, int y, int width, int height ) : this( texture, new Rectangle( x, y, width, height ) )
		{}


		/// <summary>
		/// convenience constructor that casts floats to ints for the sourceRect
		/// </summary>
		/// <param name="texture">Texture.</param>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="width">Width.</param>
		/// <param name="height">Height.</param>
		public Subtexture( Texture2D texture, float x, float y, float width, float height ) : this( texture, (int)x, (int)y, (int)width, (int)height )
		{}


		public override string ToString()
		{
			return string.Format( "{0}", sourceRect );
		}
	}
}