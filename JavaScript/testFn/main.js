const generateKeywords = (displayName) => {
	let keywords = [displayName];
	const fullName = displayName.split(" ").filter((word) => word);

	const createKeywords = (name) => {
		const arrName = [];
		let curName = "";
		name.split("").forEach((letter) => {
			curName += letter;
			arrName.push(curName);
		});
		return arrName;
	};

	for (let i = 0; i < fullName.length; i++) {
		const tem = createKeywords(fullName[i]);
		keywords = [...keywords, ...tem];
	}
	return keywords;
};

console.log(generateKeywords("nhựt duy"));
