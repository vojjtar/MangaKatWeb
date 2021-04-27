<template>
    <div id="mainDiv">
        <div id="downloadDiv">
            <input type="text">
            <a v-on:click="sendData()">
                <img src="@/assets/images/MangaKatLogo.png" alt="">
            </a>
        </div>
    </div>
</template>


<script>

import axios from 'axios'

export default {
    name: "Main",
    
    // mounted aby se to dalo hned po nasteni asi
    methods: {
        sendData: function(){
            axios({
            method: 'post',
            url: 'http://localhost:5000',
            data: {
                firstName: 'Finn',
                lastName: 'Williams'
            }
            });
        }
    }
}
</script>




<style scoped src="@/assets/css/main.css"/>