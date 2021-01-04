function lockedProfile() {
    let profiles = Array.from(document.getElementsByClassName('profile'));

    profiles.forEach(x => x.addEventListener('click', eventHandler));

    function eventHandler(e) {
        
        let eventTarget = e.target;
        let unlockButtonCondition = eventTarget.parentNode.firstElementChild.nextElementSibling.nextElementSibling.nextElementSibling.nextElementSibling;
        let displayStatus = eventTarget.previousElementSibling.style;

        if (eventTarget.textContent === 'Show more') {
            if (unlockButtonCondition.checked === true) {
                displayStatus.display = 'block';
                eventTarget.textContent = 'Hide it';
            }
        } else if (eventTarget.textContent === 'Hide it') {
            if (unlockButtonCondition.checked === true) {
                displayStatus.display = 'none';
                eventTarget.textContent = 'Show more';
            }
        }
    }
}