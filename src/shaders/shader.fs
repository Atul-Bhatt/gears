#version 330 core

out vec4 FragColor;
in vec4 TexCoord;

// texture samplers
uniform sample2D texture1;
uniform sample2D texture2;

void main() {
	// linearly interpolate between both textures (80% container, 20% awesomeface)
    FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);
}
