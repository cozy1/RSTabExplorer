using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs.effects{
	public  class FadeInGlyph : global::alphatab.rendering.Glyph {
		public    FadeInGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    FadeInGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.effects.FadeInGlyph.__hx_ctor_alphatab_rendering_glyphs_effects_FadeInGlyph(this, x, y);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_effects_FadeInGlyph(global::alphatab.rendering.glyphs.effects.FadeInGlyph __temp_me257, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y){
			unchecked {
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me257, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ));
				int __temp_y256 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x255 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.effects.FadeInGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.effects.FadeInGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]));
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				int size = ((int) (( 6 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				canvas.beginPath();
				canvas.moveTo(((double) (( cx + this.x )) ), ((double) (( cy + this.y )) ));
				canvas.quadraticCurveTo(((double) (( ( cx + this.x ) + ( this.width / 2 ) )) ), ((double) (( cy + this.y )) ), ((double) (( ( cx + this.x ) + this.width )) ), ((double) (( ( cy + this.y ) - size )) ));
				canvas.moveTo(((double) (( cx + this.x )) ), ((double) (( cy + this.y )) ));
				canvas.quadraticCurveTo(((double) (( ( cx + this.x ) + ( this.width / 2 ) )) ), ((double) (( cy + this.y )) ), ((double) (( ( cx + this.x ) + this.width )) ), ((double) (( ( cy + this.y ) + size )) ));
				canvas.stroke();
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paint") ), ((int) (1028568990) ))) );
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
	}
}


