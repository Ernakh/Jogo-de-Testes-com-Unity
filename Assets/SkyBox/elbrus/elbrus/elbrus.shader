//****************************************************//
//									//
//		elbrus.shader for Q3Radiant			//
//		Elbrus skybox by Speedy 			//
//		www.planetquake.com/speedy			//
//	note:  you might need to tweak _sun par		//

// Direction & elevation checked and adjusted - Speaker
//****************************************************//

textures/skies/elbrus
{
	qer_editorimage env/elbrus/elbrus_view.tga
	surfaceparm noimpact
	surfaceparm nolightmap
	q3map_globaltexture
	q3map_lightsubdivide 256
	q3map_surfacelight 65
	surfaceparm sky
	q3map_sun 0.8 0.75 0.6 80 40 75
	skyparms env/elbrus/elbrus - -
}
