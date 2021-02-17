export function registerUser(email, password) {
    return firebase.auth().createUserWithEmailAndPassword(email, password);
}
export function loginUser(email, password) {
    return firebase.auth().signInWithEmailAndPassword(email, password);
}
export function logout() {
    return firebase.auth().signOut();
}

export function createTeam(team) {    
    return firebase.firestore().collection('teams').add(team);    
}

export function getTeams() {
    return firebase.firestore().collection('teams').get();
}

export function setUserToTeamId(userId, teamId) {
    return firebase.firestore().collection('teams').doc(userId).update(teamId);
}

export function getTeamById(teamId) {
    return firebase.firestore().collection('teams').doc(teamId).get();
}

