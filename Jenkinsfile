pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
				bat 'dotnet build'
            }
        }
        stage('Test') {
            steps {
                bat 'dotnet test'
            }
        }
        stage('Deploy') {
            steps {

				}
            }
        }
    }
	post {
	always{
		echo 'Finished'
		deleteDir()	/*Clean up our workspace*/
		}
	}
}