function focus() {
    let div = [...document.querySelectorAll('input')].forEach(x => x.addEventListener('focus', listener));

    function listener(e) {

        let elements = [...document.querySelectorAll('input')];

        e.target.parentElement.classList.add('focused');

        elements.filter(x => x !== e.target).forEach(x => x.parentElement.classList.remove('focused'));
    }
}