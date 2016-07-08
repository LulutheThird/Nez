## Nez FNA Shader Compiler
This script builds the Nez shaders with fxc.exe from the DirectX SDK. The ShaderCompilerScript requires that the `shaderCompilerPath` parameter point to a valid Wine bottle that is setup with fxc.exe in the root. The app can be made with any Wine bottle/cask maker such as Wineskin Winery.

Once Wine is setup the script can be opened and run. The shaders will be compiled to fbx's. Note that the shaders from effects/transitions need to be manually coped to the proper directory after they are compiled.