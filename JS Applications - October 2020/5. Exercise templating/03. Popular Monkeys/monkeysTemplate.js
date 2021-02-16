window.addEventListener('load', async () => {

    const monkeysEl = document.querySelector('.monkeys');
    monkeysEl.addEventListener('click', handler)

    let templateString = await (await fetch('./main-template.hbs')).text();
    let template = Handlebars.compile(templateString);

    monkeys.forEach(element => {
        let result = template(element);
        monkeysEl.innerHTML += result;
    });

    function handler(e) {
        if (e.target.nodeName !== 'BUTTON') { return; }
        const paragraph = e.target.parentElement.querySelector('p');
        if (paragraph.style.display == 'block') {
            paragraph.style.display = 'none';
        } else {
            paragraph.style.display = 'block';
        }
    }
})