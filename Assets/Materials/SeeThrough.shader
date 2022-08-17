Shader "Unlit/SeeThrough"
{
    SubShader
    {
        Tags {"Queue" = "Transparent+2"} //3002 queue

        Pass {Blend Zero One}
    }
}
