function meemi() {
	const options = {
		method: 'GET',
		headers: {
			'X-RapidAPI-Host': 'daily-cat-facts.p.rapidapi.com',
			'X-RapidAPI-Key': 'cfba08aaeemshe0ede10b232c952p194b7djsnfd262fc2ee2a'
		}
	};

	fetch('https://daily-cat-facts.p.rapidapi.com/facts/random?amount=5', options)
		.then(response => response.json())
		.then(response => console.log(response))
		.catch(err => console.error(err));
}
