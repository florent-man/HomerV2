{{- define "homerv2.hosts.blazorserver" -}}
{{- print "https://" (.Values.global.hosts.blazorserver | replace "[RELEASE_NAME]" .Release.Name) -}}
{{- end -}}
