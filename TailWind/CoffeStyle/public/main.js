const topMenu = document.getElementById("ct-top-menu");
const ToggleTopMenuIcon = document.getElementById("ct-toggle-top-menu-icon");

document.addEventListener("click", (e) => {
	// Click to toggle top menu icon
	if (ToggleTopMenuIcon.contains(e.target)) {
		topMenu.classList.toggle("hidden");
		topMenu.classList.toggle("ct-topmenu-expanded");
	}
	// Click outside
	else {
		if (topMenu.classList.contains("ct-topmenu-expanded")) {
			topMenu.classList.remove("ct-topmenu-expanded");
			topMenu.classList.add("hidden");
		}
	}
});
