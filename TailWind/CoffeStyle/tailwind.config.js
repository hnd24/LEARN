// tailwind.config.js
const plugin = require("tailwindcss/plugin");
const defaultTheme = require("tailwindcss/defaultTheme");
module.exports = {
	content: ["./src/**/*.{html,js}", "./public/**/*.{html,js}"],
	theme: {
		screens: {
			"xs": "480px",
			...defaultTheme.screens,
		},
		extend: {
			fontFamily: {
				Karla: ["Karla", "sans-serif"],
			},
			colors: {
				"coffee": {
					50: "#E8D6D0",
					200: "#C89F94",
					400: "#A25F4B",
					600: "#744838",
				},
			},
		},
		animation: {
			slideDown: "slideDown .4s ease-in-out",
			fadeIn: "fadeIn .4s ease-in-out",
		},
		keyframes: {
			slideDown: {
				"0%": {transform: "translateY(-100%)"},
				"100%": {transform: "translateY(0)"},
			},
			fadeIn: {
				from: {opacity: 0},
				to: {opacity: 1},
			},
		},
		backgroundImage: {
			"slider-bg": "url('./imgs/slider-bg.jpg')",
		},
	},
	plugins: [],
};
