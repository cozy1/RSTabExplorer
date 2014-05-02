using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio{
	public  class MidiUtils : global::haxe.lang.HxObject {
		static MidiUtils() {
			global::alphatab.audio.MidiUtils.QuarterTime = 960;
			global::alphatab.audio.MidiUtils.PercussionChannel = 9;
			global::alphatab.audio.MidiUtils.MinVelocity = 15;
			global::alphatab.audio.MidiUtils.VelocityIncrement = 16;
		}
		public    MidiUtils(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MidiUtils(){
			unchecked {
				global::alphatab.audio.MidiUtils.__hx_ctor_alphatab_audio_MidiUtils(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_MidiUtils(global::alphatab.audio.MidiUtils __temp_me55){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  int QuarterTime;
		
		public static  int PercussionChannel;
		
		public static   int durationToTicks(global::alphatab.model.Duration @value){
			unchecked {
				return global::alphatab.audio.MidiUtils.valueToTicks(global::alphatab.model.ModelUtils.getDurationValue(@value));
			}
		}
		
		
		public static   int valueToTicks(int @value){
			unchecked {
				return ((int) (( 960 * (( 4.0 / @value )) )) );
			}
		}
		
		
		public static   int applyDot(int ticks, bool doubleDotted){
			unchecked {
				if (doubleDotted) {
					return ( ticks + ((int) (( ( ((double) (ticks) ) / 4 ) * 3 )) ) );
				}
				 else {
					return ( ticks + ( ticks / 2 ) );
				}
				
			}
		}
		
		
		public static   int applyTuplet(int ticks, int numerator, int denominator){
			unchecked {
				return ( ( ticks * denominator ) / numerator );
			}
		}
		
		
		public static  int MinVelocity;
		
		public static  int VelocityIncrement;
		
		public static   int dynamicToVelocity(global::alphatab.model.DynamicValue dynamicValue){
			unchecked {
				return ( 15 + ( global::haxe.root.Type.enumIndex(dynamicValue) * 16 ) );
			}
		}
		
		
		public static   global::alphatab.audio.model.MidiTickLookup buildTickLookup(global::alphatab.model.Score score){
			unchecked {
				global::alphatab.audio.model.MidiTickLookup lookup = new global::alphatab.audio.model.MidiTickLookup();
				global::alphatab.audio.generator.MidiPlaybackController controller = new global::alphatab.audio.generator.MidiPlaybackController(((global::alphatab.model.Score) (score) ));
				int tick = 0;
				while ( ! ((( controller.index >= controller._score.masterBars.length ))) ){
					int index = controller.index;
					int repeatMove = controller.repeatMove;
					controller.process();
					if (controller.shouldPlay) {
						global::alphatab.audio.model.BarTickLookup bar = new global::alphatab.audio.model.BarTickLookup();
						bar.bar = ((global::alphatab.model.MasterBar) (score.masterBars[index]) );
						bar.start = ( controller.repeatMove + bar.bar.start );
						bar.end = ( bar.start + bar.bar.calculateDuration() );
						lookup.bars.push(bar);
					}
					
				}
				
				return lookup;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.audio.MidiUtils(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.audio.MidiUtils();
			}
		}
		
		
	}
}


