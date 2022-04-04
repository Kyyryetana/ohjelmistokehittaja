//API ohjelmointi meemejä

function meemi() {
	const options = {
		method: 'GET',
		headers: {
			'X-RapidAPI-Host': 'programming-memes-images.p.rapidapi.com',
			'X-RapidAPI-Key': 'cfba08aaeemshe0ede10b232c952p194b7djsnfd262fc2ee2a'
		}
	};

	fetch('https://programming-memes-images.p.rapidapi.com/v1/memes', options)
		.then(response => response.json())
		.then(response => console.log(response))
		.catch(err => console.error(err));
}
