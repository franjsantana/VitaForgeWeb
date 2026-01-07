import { initializeApp } from "https://www.gstatic.com/firebasejs/12.7.0/firebase-app.js";
import { getAnalytics } from "https://www.gstatic.com/firebasejs/12.7.0/firebase-analytics.js";
import { getAuth, signInWithEmailAndPassword, createUserWithEmailAndPassword, signOut, onAuthStateChanged } from "https://www.gstatic.com/firebasejs/12.7.0/firebase-auth.js";
import { getFirestore, doc, getDoc, setDoc } from "https://www.gstatic.com/firebasejs/12.7.0/firebase-firestore.js";

const firebaseConfig = {
    apiKey: "AIzaSyD-8q9xQ-xEMQVCRWPjd2_O7912pZ-vqsA",
    authDomain: "vitaforgeweb.firebaseapp.com",
    projectId: "vitaforgeweb",
    storageBucket: "vitaforgeweb.firebasestorage.app",
    messagingSenderId: "210832457196",
    appId: "1:210832457196:web:771dbf742b33b92da014c9",
    measurementId: "G-BRHPEB6FCL"
};

const app = initializeApp(firebaseConfig);
const analytics = getAnalytics(app);
const auth = getAuth(app);
const db = getFirestore(app);

window.vitaForge = {
    login: async (email, password) => {
        try {
            const userCredential = await signInWithEmailAndPassword(auth, email, password);
            return {
                success: true,
                uid: userCredential.user.uid,
                email: userCredential.user.email
            };
        } catch (error) {
            return { success: false, error: error.message };
        }
    },
    register: async (email, password) => {
        try {
            const userCredential = await createUserWithEmailAndPassword(auth, email, password);
            return {
                success: true,
                uid: userCredential.user.uid,
                email: userCredential.user.email
            };
        } catch (error) {
            return { success: false, error: error.message };
        }
    },
    logout: async () => {
        try {
            await signOut(auth);
            return { success: true };
        } catch (error) {
            return { success: false, error: error.message };
        }
    },
    saveUserData: async (uid, dataJson) => {
        try {
            const data = JSON.parse(dataJson);
            await setDoc(doc(db, "users", uid), data);
            return { success: true };
        } catch (error) {
            return { success: false, error: error.message };
        }
    },
    getUserData: async (uid) => {
        try {
            const docRef = doc(db, "users", uid);
            const docSnap = await getDoc(docRef);
            if (docSnap.exists()) {
                return { success: true, data: JSON.stringify(docSnap.data()) };
            } else {
                return { success: false, error: "No data found" };
            }
        } catch (error) {
            return { success: false, error: error.message };
        }
    },
    getCurrentUser: () => {
        return new Promise((resolve) => {
            const unsubscribe = onAuthStateChanged(auth, (user) => {
                unsubscribe();
                if (user) {
                    resolve({ uid: user.uid, email: user.email });
                } else {
                    resolve(null);
                }
            });
        });
    }
};
